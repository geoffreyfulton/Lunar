using System;
using System.IO;
using Pluto.PortableExecutable;

namespace Pluto.RemoteProcess.Structures
{
    internal sealed class Module
    {
        internal IntPtr BaseAddress { get; }

        internal string Name { get; }

        internal Lazy<PeImage> PeImage { get; }

        internal Module(IntPtr baseAddress, string filePath, string name)
        {
            BaseAddress = baseAddress;

            Name = name;

            PeImage = new Lazy<PeImage>(() => new PeImage(File.ReadAllBytes(filePath)));
        }
    }
}