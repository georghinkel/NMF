using System;

namespace NMF.Controls.Diagrams
{
    public interface IGroupable
    {
        IGroupable Group { get; set; }
        bool IsGroup { get; set; }
    }
}
