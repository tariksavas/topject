using Runtime.SignalBus.Installer;
using System;
using UnityEngine;

namespace Runtime.DependencyInjection
{
    [DefaultExecutionOrder(-200)]
    public sealed class ProjectInstaller : MonoBehaviour
    {
        private void Awake()
        {
            Install();
            CreateKernel();
        }

        private void Install()
        {
            Install<SignalInstaller>();
        }

        private void CreateKernel()
        {
            GameObject kernel = new GameObject("MonoKernel", typeof(MonoKernel));
            kernel.transform.parent = transform;
            DontDestroyOnLoad(transform);
        }

        private void Install<T>() where T : DiInstaller
        {
            T installer = (T)Activator.CreateInstance(typeof(T));
            installer.Install();
        }
    }
}