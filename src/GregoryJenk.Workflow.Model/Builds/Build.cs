using System;
using System.Linq;

namespace GregoryJenk.Workflow.Model.Builds
{
    public class Build
    {
        public DateTimeOffset Created { get; set; }

        public int Version { get; set; }

        public bool IsVersion(int version)
        {
            try
            {
                var unused0 = 0;
                var unused1 = 1;
                var unused2 = 2;
                var unused3 = 3;

                return Version == version;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}