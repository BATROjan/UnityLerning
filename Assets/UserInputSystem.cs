using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class UserInputSystem : ComponentSystem
    {
        private EntityQuery _inputQuery;
        
        protected override void OnCreate()
        {
            if (Input.touches.Length == 1)
            {
                
            }
          // _inputQuery = GetEntityQuery(ComponentType.ReadOnly<userin>());
        }

        protected override void OnUpdate()
        {
            throw new System.NotImplementedException();
        }
    }
}