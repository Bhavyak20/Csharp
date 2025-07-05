using System;
using StaticAndNonstatic;

namespace Nonstatic
{
    public class NonstaticProgram
    {
     public static void Main()
        {
            ProgramNonstatic programNonstatic = new ProgramNonstatic();
            programNonstatic.MainMessage();
            //here i called other program nonstatic method with using namespace and instance

            StaticProgram.MainMessage();
            Console.WriteLine($"I'm printing my name which is mentioned in Another program with help of namespace and Class{StaticProgram.Myname}");
        }
    }
}
