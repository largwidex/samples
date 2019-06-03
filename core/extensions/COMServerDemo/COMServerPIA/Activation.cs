using System;
using System.Runtime.InteropServices;

// The following classes are typically defined in a PIA, but for this example
// are being defined here to simplify the scenario.
namespace Activation
{
    /// <summary>
    /// Managed definition of CoClass 
    /// </summary>
    [ComImport]
    [CoClass(typeof(ServerClass))]
    [Guid(ContractGuids.ServerInterface)] // By TlbImp convention, set this to the GUID of the parent interface
    public interface Server : IServer
    {
    }

    /// <summary>
    /// Managed activation for CoClass
    /// </summary>
    [ComImport]
    [Guid(ContractGuids.ServerClass)]
    public class ServerClass
    {
    }
}

