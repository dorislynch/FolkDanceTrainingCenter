using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Folk.Dance.Training.Center.RNFolkDanceTrainingCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFolkDanceTrainingCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFolkDanceTrainingCenterModule"/>.
        /// </summary>
        internal RNFolkDanceTrainingCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFolkDanceTrainingCenter";
            }
        }
    }
}
