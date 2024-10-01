using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Dancer.Show.Center.RNDancerShowCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDancerShowCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDancerShowCenterModule"/>.
        /// </summary>
        internal RNDancerShowCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDancerShowCenter";
            }
        }
    }
}
