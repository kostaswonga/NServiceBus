﻿using System.Security.Principal;
using NServiceBus.Installation;
using NServiceBus.Utils;

namespace NServiceBus.Faults.Forwarder.Config
{
    class Installer : INeedToInstallSomething<Installation.Environments.Windows>
    {
        public void Install(WindowsIdentity identity)
        {
            MsmqUtilities.CreateQueueIfNecessary(ConfigureFaultsForwarder.ErrorQueue, identity.Name);
        }
    }
}
