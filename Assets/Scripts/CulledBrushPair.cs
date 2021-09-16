using UnityEngine;

namespace TiltBrush
{
    [System.Serializable]
    public class CulledBrushPair //: ScriptableObject
    {
        [SerializeField]
        public BrushDescriptor doubleSided;
        [SerializeField]
        public BrushDescriptor singleSided;
    }
} // namespace TiltBrush