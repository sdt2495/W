using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // 敵を消す
            Destroy(gameObject);           // 弾を消す

            GameManager.enemyCount--;      // 敵数を減らす

            // 全滅チェック
            if (GameManager.enemyCount <= 0)
            {
                SceneManager.LoadScene("Result");
            }
        }
    }
}