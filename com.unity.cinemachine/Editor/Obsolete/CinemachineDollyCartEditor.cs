using UnityEditor;

namespace Cinemachine.Editor
{
    [System.Obsolete]
    [CustomEditor(typeof(CinemachineDollyCart))]
    [CanEditMultipleObjects]
    class CinemachineDollyCartEditor : BaseEditor<CinemachineDollyCart>
    {
        public override void OnInspectorGUI()
        {
            BeginInspector();
            UpgradeManagerInspectorHelpers.DrawUpgradeControls(this, "Upgrade to CinemachineSplineCart");
            DrawRemainingPropertiesInInspector();
        }
    }
}