using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.BinarySerializer.Converters;
using Polkadot.BinaryContracts.Nft;
using Polkadot.BinaryContracts.Common;
using System.Numerics;

namespace Polkadot.BinaryContracts.Common
{
    public class Address
    {
        // Rust type AccountId
        [Serialize(0)]
        public PublicKey Value { get; set; }



        public Address() { }
        public Address(PublicKey @value)
        {
            this.Value = @value;
        }

    }
}