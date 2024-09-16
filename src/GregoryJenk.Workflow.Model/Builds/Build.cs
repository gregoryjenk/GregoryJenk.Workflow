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
                return Version == version;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}