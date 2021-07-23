# Dashboard_Villars_dotnet

.net dashboard application for a lamination machine @ Vetex nv.
Application will run on a panel PC running Windows 10 IOT.

The application gets the machine status from our IoT gateway through MQTT.

User is able to enter which PO (Production Order) they will run.
They can also enter the different fabric rolls and membrames.
Afterwards the operator can enter how much meters they used from the rolls.
Operator is also able to send an event update to an Azure data lake database.
