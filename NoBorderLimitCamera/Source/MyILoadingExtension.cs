using ICities;
using UnityEngine;

namespace NoBorderLimitCameraNamespace
{
    public class MyILoadingExtension: ILoadingExtension
    {
		public void OnCreated(ILoading loading)
		{

		}

		public void OnReleased()
		{
	
		}
		public void OnLevelLoaded(LoadMode mode)
		{
			Camera.main.GetComponent<CameraController>().m_unlimitedCamera = true;
		}
		public void OnLevelUnloading()
		{
			
		}
	 }
}
