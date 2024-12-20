using System.Collections;
using UnityEngine;

namespace CoreConcepts
{
    public class ConceptExecutor : MonoBehaviour
    {
        private void Start()
        {

            TestingCoroutine();
        }

        private void TestingCoroutine()
        {
            Debug.Log("Starting coroutine");
            StartCoroutine(BasicCoroutine());
        }

        private IEnumerator BasicCoroutine()
        {
            //Frame 1
            Debug.Log("Frame 1");
            yield return null;

            //Frame 2
            Debug.Log("Frame 2");
            yield return new WaitForSeconds(5f);

            //Frame 3
            Debug.Log("Coroutine ended");

        }
    }
}
