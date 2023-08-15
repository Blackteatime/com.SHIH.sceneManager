using UnityEngine;

namespace SHIH.SceneManager
{
    /// <summary>
    /// 場景管理器:切換場景或退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        [SerializeField,Range(0.1f,1),Header("播放時間")]
        float soundDuration = 0.7f;

        string nameSceneToChange;
        /// <summary>
        /// 透過字串切換場景
        /// </summary>
        /// <param name="nameScene">場景名稱</param>
        public void ChangeScene(string nameScene)
        {
            nameSceneToChange = nameScene;
            Invoke("DelayChangeScene", soundDuration);
        }
        public void DelayChangeScene()
        {
            //print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameSceneToChange);

        }
        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }
        public void DelayQuit()
        {
            //print("退出遊戲");
            Application.Quit();

        }
    }

}
