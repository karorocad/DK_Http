using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace DK_http
{
    public class DK_httpInfo : GH_AssemblyInfo
    {
        public override string Name => "DK_Http";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "Rebuild of Bengesht Http Server for use in Rhino 8";

        public override Guid Id => new Guid("8adde728-bc48-45f6-80d4-abb37a8834ae");

        //Return a string identifying you or your company.
        public override string AuthorName => "David Kay";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "karorocad@gmail.com";

        //Return a string representing the version.  This returns the same version as the assembly.
        public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();

        public static string getComponentDescription(string str)
        {
            string output = str +
                "DK Http Server for GH";

            return output;
        }
    }
}