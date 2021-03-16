using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using Polkadot.BinaryContracts.Common;
using System.Numerics;

namespace Polkadot.BinaryContracts.Events.System
{
    public partial class NewAccount : IEvent
    {
        // Rust type AccountId
        [Serialize(0)]
        public PublicKey EventArgument0 { get; set; }



        public NewAccount() { }
        public NewAccount(PublicKey @eventArgument0)
        {
            this.EventArgument0 = @eventArgument0;
        }

    }
}