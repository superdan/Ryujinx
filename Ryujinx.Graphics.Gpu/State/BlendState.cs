using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Gpu.State
{
    /// <summary>
    /// Color buffer blending parameters.
    /// </summary>
    struct BlendState
    {
#pragma warning disable CS0649
        public Boolean32   SeparateAlpha;
        public BlendOp     ColorOp;
        public BlendFactor ColorSrcFactor;
        public BlendFactor ColorDstFactor;
        public BlendOp     AlphaOp;
        public BlendFactor AlphaSrcFactor;
        public BlendFactor AlphaDstFactor;
        public uint        Padding;
#pragma warning restore CS0649
    }
}
