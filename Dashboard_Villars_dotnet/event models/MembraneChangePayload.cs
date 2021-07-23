using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vet.IoT.Mqtt.Client;

namespace Dashboard_Villars_dotnet.event_models
{
    public class MembraneChangePayload : Payload
    {
        public MembraneChangePayload(DateTimeOffset timestamp) : base(timestamp) { }

        public string PO { get; set; }
        public int Passage { get; set; }
        public string Code { get; set; }
        public int Length { get; set; }

        public string Text { get; set; }
    }
}
