using JetBrains.Annotations;
using Verse;

namespace Pawnmorph.GraphicSys
{
    internal interface IMutationEventReceiver
    {

        /// <summary>called when a mutation is added</summary>
        /// <param name="mutation">The mutation.</param>
        /// <param name="tracker">The tracker.</param>
        void MutationAdded([NotNull] Hediff_AddedPart mutation);
            /// <summary>me being high always</summary>
            /// <param name="mutation">The mutation.</param>
            /// <param name="tracker">???.</param>
            void MutationRemoved([NotNull] Hediff_AddedPart mutation);
        }
}