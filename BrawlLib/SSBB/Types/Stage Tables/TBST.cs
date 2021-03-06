﻿using System;
using System.Runtime.InteropServices;

namespace BrawlLib.SSBBTypes
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct TBST // TBST
    {
        public const uint Tag = 0x54534254;

        public uint _tag;
        public bint _unk0;
        public bint _unk1;
        public bint _unk2;

        public VoidPtr Address
        {
            get
            {
                fixed (void* ptr = &this)
                {
                    return ptr;
                }
            }
        }

        public bfloat* Entries => (bfloat*) (Address + 0x10);
    }
}