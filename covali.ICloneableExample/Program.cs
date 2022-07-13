Console.WriteLine("***** A First Look at Interfaces******\n");

string mysStr = "Hello";
OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
//System.Data.SqlTypes.SqlXml ex = new System.Data.SqlTypes.SqlXml();
CloneMe(mysStr);
CloneMe(unixOS);
//CloneMe(ex);

static void CloneMe(ICloneable c)
{
    object theClone = c.Clone();
    Console.WriteLine($"Your clone is a: {theClone.GetType().Name}");
}
