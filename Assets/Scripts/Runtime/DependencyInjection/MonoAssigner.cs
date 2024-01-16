using UnityEngine;

namespace Runtime.DependencyInjection
{
    public class MonoAssigner : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Assign();
        }

        private void Assign()
        {
            this.AssignInjectionToFields();
        }
    }
}