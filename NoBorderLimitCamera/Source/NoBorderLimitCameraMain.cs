using ICities;
using UnityEngine;

namespace NoBorderLimitCameraNamespace
{
    public class NoBorderLimitCameraMain: IUserMod
    {
        public string Name {
            get { return "No Border Limit Camera"; }
        }

        public string Description {
            get { return "Camera can travel outside of the city limits"; }
        }
    }
}
