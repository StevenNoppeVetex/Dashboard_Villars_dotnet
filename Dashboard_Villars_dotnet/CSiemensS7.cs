using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp7;
using System.Windows.Forms;

/* Class to use Sharp7 - version 0.2.2
 * 
 * History :
 * ---------
 * november 2020 - V0.2 : first version
 * 21 march 2021 - v0.2.1 : * BUG FIX : Default constructor was empty
 *                                      Added a S7Client, S7Client.S7OrderCode and a DateTime object
 * 22 march 2021 - v0.2.2 : * BUG FIX : Default values for datatype and datalength were faulty
 *                                      
 * Usage : 
 * -------
 * private CSiemensS7 MyPLC = new CSiemensS7();
 * 
 * MyPLC.ConnectTo("My PLC", "192.168.0.100", 0, 0); // for S7-1500 PLCs
 * MyPLC.ConnectTo("My PLC", "192.168.0.100", 0, 2); // for S7-300 PLCs
 * 
 */
namespace Dashboard_Villars_dotnet
{
    class CSiemensS7
    {
        private string m_strPLCName                             = "";
        private string m_strDataType                            = "int";
        private int m_iDataType;
        private string m_strDataLength                          = "int";
        private int m_iDataLength;
        private string m_strDataArea                            = "MK";
        private int m_iDataArea;
        private int m_iDataDBnumber                             = 1;
        private int m_iDataLocation                             = 1;
        private byte[] m_DataBuffer                             = new byte[65536];
        private string m_strData;

        private string m_strIPAddress;
        private int m_iRack;
        private int m_iSlot;

        private S7Client m_Client;
        private S7Client.S7OrderCode m_Info;

        private DateTime m_DateTime;
        private int m_iPLCStatus;

        public CSiemensS7()
        {
            m_Client = new S7Client();
            m_Info = new S7Client.S7OrderCode();
            m_DateTime = new DateTime();
        }

        public string PLCName { get => m_strPLCName; set => m_strPLCName = value; }
        public string IPAddress { get => m_strIPAddress; set => m_strIPAddress = value; }
        public int Rack { get => m_iRack; set => m_iRack = value; }
        public int Slot { get => m_iSlot; set => m_iSlot = value; }
        public string DataType { get => m_strDataType; set => m_strDataType = value; }
        public string DataLength { get => m_strDataLength; set => m_strDataLength = value; }
        public string DataArea { get => m_strDataArea; set => m_strDataArea = value; }
        public int DataDBnumber { get => m_iDataDBnumber; set => m_iDataDBnumber = value; }
        public int DataLocation { get => m_iDataLocation; set => m_iDataLocation = value; }
        public string Data { get => m_strData; set => m_strData = value; }
        public CSiemensS7(string PLCName, string IPAddress, int iRack, int iSlot)
        {
            m_Client                                            = new S7Client();
            m_Info                                              = new S7Client.S7OrderCode();
            m_DateTime                                          = new DateTime();

            m_strPLCName                                        = PLCName;
            m_strIPAddress                                      = IPAddress;
            m_iRack                                             = iRack;
            m_iSlot                                             = iSlot;
        }
        public int ConnectPLC()
        {
            if (m_strIPAddress == null)
                return 1;

            if (m_iRack < 0)
                return m_Client.ConnectTo(m_strIPAddress, 0, m_iSlot);

            if (m_iSlot < 0)
                return m_Client.ConnectTo(m_strIPAddress, m_iRack, 0);

            return m_Client.ConnectTo(m_strIPAddress, 0, 0);
        }

        public int ConnectTo(string PLCName, string strIPAddress, int iRack, int iSlot)
        {
            m_strPLCName                                        = PLCName;
            m_strIPAddress                                      = strIPAddress;
            m_iRack                                             = iRack;
            m_iSlot                                             = iSlot;

            return m_Client.ConnectTo(strIPAddress, m_iRack, m_iSlot);
        }

        public int Disconnect()
        {
            return m_Client.Disconnect();
        }

        public bool PLCconnected()
        {
            return m_Client.Connected;
        }

        public string GetPLCData()
        {
            /*
            type : 
             0 Byte    8 Bit Word(All)
             1 Word   16 Bit Word(All)
             2 DWord  32 Bit Word(All)
             3 LWord  64 Bit Word(S71500)
             4 USint   8 Bit Unsigned Integer(S71200 / 1500)
             5 UInt   16 Bit Unsigned Integer(S71200 / 1500)
             6 UDInt  32 Bit Unsigned Integer(S71200 / 1500)
             7 ULint  64 Bit Unsigned Integer(S71500)
             8 Sint    8 Bit Signed Integer(S71200 / 1500)
             9 Int    16 Bit Signed Integer(All)
            10 DInt   32 Bit Signed Integer(S71200 / 1500)
            11 LInt   64 Bit Signed Integer(S71500)
            12 Real   32 Bit Floating point(All)
            13 LReal  64 Bit Floating point(S71200 / 1500)
            14 Time   32 Bit Time elapsed ms(All)
            15 LTime  64 Bit Time Elapsed ns(S71500)
            16 Date   16 Bit days from 1990 / 1 / 1(All)
            17 TOD    32 Bit ms elapsed from midnight(All)
            18 DT      8 Byte Date and Time(All)
            19 LTOD   64 Bit time of day(ns)         (S71500)
            20 DTL    12 Byte Date and Time Long(S71200 / 1500)
            21 LDT    64 Bit ns elapsed from 1970 / 1 / 1(S71500)
            */

            // Declaration separated from the code for readability
            int iAmount                                             = 1;
            int iSizeRead                                           = 0;
            int iResult                                             = 0;
            int iPos                                                = 0;

            int[] Area =
            {
                 S7Consts.S7AreaPE,
                 S7Consts.S7AreaPA,
                 S7Consts.S7AreaMK,
                 S7Consts.S7AreaDB,
                 S7Consts.S7AreaCT,
                 S7Consts.S7AreaTM
            };
            int[] WordLen =
            {
                 S7Consts.S7WLBit,
                 S7Consts.S7WLByte,
                 S7Consts.S7WLChar,
                 S7Consts.S7WLWord,
                 S7Consts.S7WLInt,
                 S7Consts.S7WLDWord,
                 S7Consts.S7WLDInt,
                 S7Consts.S7WLReal,
                 S7Consts.S7WLCounter,
                 S7Consts.S7WLTimer
            };

            switch (m_strDataArea)
            {
                case "PE":
                    {
                        m_iDataArea = 0;
                        break;
                    }

                case "PA":
                    {
                        m_iDataArea = 1;
                        break;
                    }

                case "MK":
                    {
                        m_iDataArea = 2;
                        break;
                    }

                case "DB":
                    {
                        m_iDataArea = 3;
                        break;
                    }
                case "CT":
                    {
                        m_iDataArea = 4;
                        break;
                    }

                case "TM":
                    {
                        m_iDataArea = 5;
                        break;
                    }

                default:
                    {
                        // default Merker => "MK"
                        m_iDataArea = 2;
                        break;
                    }
            }

            switch (m_strDataLength)
            {
                case "bit":
                    {
                        m_iDataLength = 0;
                        break;
                    }

                case "byte":
                    {
                        m_iDataLength = 1;
                        break;
                    }

                case "char":
                    {
                        m_iDataLength = 2;
                        break;
                    }

                case "word":
                    {
                        m_iDataLength = 3;
                        break;
                    }
                case "int":
                    {
                        m_iDataLength = 4;
                        break;
                    }

                case "dword":
                    {
                        m_iDataLength = 5;
                        break;
                    }
                case "dint":
                    {
                        m_iDataLength = 6;
                        break;
                    }

                case "real":
                    {
                        m_iDataLength = 7;
                        break;
                    }

                case "counter":
                    {
                        m_iDataLength = 8;
                        break;
                    }

                case "timer":
                    {
                        m_iDataLength = 9;
                        break;
                    }

                default:
                    {
                        // Default = byte
                        m_iDataLength = 1;
                        break;
                    }
            }

            switch (m_strDataType)
            {
                case "byte":
                    {
                        m_iDataType = 0;
                        break;
                    }

                case "word":
                    {
                        m_iDataType = 1;
                        break;
                    }

                case "dword":
                    {
                        m_iDataType = 2;
                        break;
                    }

                case "lword":
                    {
                        m_iDataType = 3;
                        break;
                    }
                case "usint":
                    {
                        m_iDataType = 4;
                        break;
                    }

                case "uint":
                    {
                        m_iDataType = 5;
                        break;
                    }
                case "udint":
                    {
                        m_iDataType = 6;
                        break;
                    }

                case "ulint":
                    {
                        m_iDataType = 7;
                        break;
                    }

                case "sint":
                    {
                        m_iDataType = 8;
                        break;
                    }

                case "int":
                    {
                        m_iDataType = 9;
                        break;
                    }

                case "dint":
                    {
                        m_iDataType = 10;
                        break;
                    }

                case "lint":
                    {
                        m_iDataType = 11;
                        break;
                    }

                case "real":
                    {
                        m_iDataType = 12;
                        break;
                    }

                case "lreal":
                    {
                        m_iDataType = 13;
                        break;
                    }
                case "time":
                    {
                        m_iDataType = 14;
                        break;
                    }

                case "ltime":
                    {
                        m_iDataType = 15;
                        break;
                    }
                case "date":
                    {
                        m_iDataType = 16;
                        break;
                    }

                case "tod":
                    {
                        m_iDataType = 17;
                        break;
                    }

                case "dt":
                    {
                        m_iDataType = 18;
                        break;
                    }

                case "ltod":
                    {
                        m_iDataType = 19;
                        break;
                    }

                case "dtl":
                    {
                        m_iDataType = 20;
                        break;
                    }

                case "ldt":
                    {
                        m_iDataType = 21;
                        break;
                    }

                default:
                    {
                        m_iDataType = 9;
                        break;
                    }
            }

            iResult = m_Client.ReadArea(Area[m_iDataArea], m_iDataDBnumber, m_iDataLocation, iAmount, WordLen[m_iDataLength], m_DataBuffer, ref iSizeRead);
            //iResult = m_Client.ReadArea(S7Consts.S7AreaDB, 200, 0, 436, S7Consts.S7WLByte, m_DataBuffer, ref iSizeRead);
            //iPos = 435;

            //iResult = m_Client.ReadArea(S7Consts.S7AreaDB, 200, 435, 1, S7Consts.S7WLByte, m_DataBuffer, ref iSizeRead);
            //iPos = 0;

            //iResult = m_Client.ReadArea(S7Consts.S7AreaDB, 200, 435, 1, S7Consts.S7WLByte, m_DataBuffer, ref iSizeRead);

            //MessageBox.Show(m_Client.ErrorText(iResult)); 
            
            if (iResult == 0)
            {
                switch (m_iDataType)
                {
                    case 0:
                        {
                            m_strData = "16#" + System.Convert.ToString(m_DataBuffer[iPos], 16).ToUpper();

                            break;
                        }
                    case 1:
                        {
                            UInt16 Word = S7.GetWordAt(m_DataBuffer, iPos);
                            m_strData = "16#" + System.Convert.ToString(Word, 16).ToUpper();

                            break;
                        }
                    case 2:
                        {
                            UInt32 DWord = S7.GetDWordAt(m_DataBuffer, iPos);
                            m_strData = "16#" + System.Convert.ToString(DWord, 16).ToUpper();

                            break;
                        }
                    case 3:
                        {
                            UInt64 LWord = S7.GetLWordAt(m_DataBuffer, iPos);
                            m_strData = "16#" + System.Convert.ToString((Int64)LWord, 16).ToUpper(); // <-- Convert.ToString does not handle UInt64

                            break;
                        }
                    case 4:
                        {
                            UInt16 USInt = S7.GetUSIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(USInt);

                            break;
                        }
                    case 5:
                        {
                            UInt16 UInt = S7.GetUIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(UInt);

                            break;
                        }
                    case 6:
                        {
                            UInt32 UDInt = S7.GetDWordAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(UDInt);

                            break;
                        }
                    case 7:
                        {
                            UInt64 ULInt = S7.GetLWordAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(ULInt);

                            break;
                        }
                    case 8:
                        {
                            int SInt = S7.GetSIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(SInt);

                            break;
                        }
                    case 9:
                        {
                            int S7Int = S7.GetIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(S7Int);

                            break;
                        }
                    case 10:
                        {
                            int DInt = S7.GetDIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(DInt);

                            break;
                        }
                    case 11:
                        {
                            Int64 LInt = S7.GetLIntAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(LInt);

                            break;
                        }
                    case 12:
                        {
                            Single S7Real = S7.GetRealAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(S7Real);

                            break;
                        }
                    case 13:
                        {
                            Double S7LReal = S7.GetLRealAt(m_DataBuffer, iPos);
                            m_strData = System.Convert.ToString(S7LReal);

                            break;
                        }
                    case 14:
                        {
                            Int32 TimeElapsed = S7.GetDIntAt(m_DataBuffer, iPos);
                            // TIME type is a 32 signed number of ms elapsed
                            // Can be added to a DateTime or used as Value.
                            m_strData = "T#" + System.Convert.ToString(TimeElapsed) + "MS";

                            break;
                        }
                    case 15:
                        {
                            Int64 TimeElapsed = S7.GetLIntAt(m_DataBuffer, iPos);
                            // LTIME type is a 64 signed number of ns elapsed
                            // Can be added (after a conversion) to a DateTime or used as Value.
                            m_strData = "LT#" + System.Convert.ToString(TimeElapsed) + "NS";

                            break;
                        }
                    case 16:
                        {
                            DateTime DATE = S7.GetDateAt(m_DataBuffer, iPos);
                            m_strData = DATE.ToString("D#yyyy-MM-dd");

                            break;
                        }
                    case 17:
                        {
                            DateTime TOD = S7.GetTODAt(m_DataBuffer, iPos);
                            m_strData = TOD.ToString("TOD#HH:mm:ss.fff");

                            break;
                        }
                    case 18:
                        {
                            DateTime DT = S7.GetDateTimeAt(m_DataBuffer, iPos);
                            m_strData = DT.ToString("DT#yyyy-MM-dd-HH:mm:ss.fff");

                            break;
                        }
                    case 19:
                        {
                            DateTime LTOD = S7.GetLTODAt(m_DataBuffer, iPos);
                            m_strData = LTOD.ToString("LTOD#HH:mm:ss.fffffff");

                            break;
                        }
                    case 20:
                        {
                            DateTime DTL = S7.GetDTLAt(m_DataBuffer, iPos);
                            m_strData = DTL.ToString("DTL#yyyy-MM-dd-HH:mm:ss.fffffff");

                            break;
                        }
                    case 21:
                        {
                            DateTime LDT = S7.GetLDTAt(m_DataBuffer, iPos);
                            m_strData = LDT.ToString("LDT#yyyy-MM-dd-HH:mm:ss.fffffff");

                            break;
                        }
                }
            }
            return m_strData;
        }

        public string GetOrderCode()
        {
            int iResult = m_Client.GetOrderCode(ref m_Info);

            if (iResult == 0)
            {
                return m_Info.Code + " - Version : " + m_Info.V1.ToString() + "." + m_Info.V2.ToString() + "." + m_Info.V3.ToString();
            }
            else
            {
                return null;
            }
        }

        public string GetPLCDateTime()
        {
            int iResult = m_Client.GetPlcDateTime(ref m_DateTime);

            if (iResult == 0)
            {
                return m_DateTime.ToLongDateString() + " - " + m_DateTime.ToLongTimeString();
            }
            else
            {
                return null;
            }
        }

        public string GetPLCStatus()
        {
            int iResult = m_Client.PlcGetStatus(ref m_iPLCStatus);

            if (iResult == 0)
            {
                switch (m_iPLCStatus)
                {
                    case S7Consts.S7CpuStatusRun:
                        {
                            return "RUN";
                        }
                    case S7Consts.S7CpuStatusStop:
                        {
                            return "STOP";
                        }
                    default:
                        {
                            return "Unknown";
                        }
                }
            }
            else
            {
                return "Unknown";
            }
        }

        public int StopPLC()
        {
            return m_Client.PlcStop();
        }

        public int HotStartPLC()
        {
            return m_Client.PlcHotStart();
        }

        public int ColdStartPLC()
        {
            return m_Client.PlcColdStart();
        }
    }
}
