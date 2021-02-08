﻿using Polkadot.BinarySerializer;
using Polkadot.BinarySerializer.Converters;

namespace Polkadot.BinaryContracts.Calls.System
{
    public class SetCode : IExtrinsicCall
    {
        [Serialize(0)]
        [PrefixedArrayConverter]
        public byte[] Code { get; set; }
    }
}