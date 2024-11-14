// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyBulletInfo : BulletTemplate
// {
//     public EnemyBulletInfo()
//     {
//         this.power = 1;//攻撃力
//         this.shootRange = 6f;//射程
//         this.shootPositionX = 0;//弾の発射位置
//         this.shootPositionY = -1f;//弾の発射位置
//         this.shootSpeedX = 0;//弾の速度
//         this.shootSpeedY = -0.01f;//弾の速度
//         this.scaleX = 0.5f;//x軸方向の大きさ
//         this.scaleY = 0.5f;//y軸方向の大きさ
//     }

//     /// <summary>
//     /// バレットオブジェクトを移動させるメソッド
//     /// x方向にはspeedX、y方向にはspeedYだけ移動させる
//     /// </summary>
//     /// <param name="bullet">弾オブジェクト</param>
//     /// <param name="speedX">x軸方向の弾の速度</param>
//     /// <param name="speedY">y軸方向の弾の速度</param>
//     public override void BulletMove(Bullet bullet, float shootRange, float speedX, float speedY)
//     {
//         this.pos = bullet.transform.position;
//         if(this.pos.y < shootRange || this.pos.y > 5.5f || -10.5 > this.pos.x ||this.pos.x > 10.5)//射程外もしくはカメラ外に出たら消す
//         {
//             GameObject.Destroy(bullet.gameObject);
//         }
//         this.pos.x += speedX;
//         this.pos.y += speedY;
//         bullet.transform.position = this.pos;
//     }

//     /// <summary>
//     /// 攻撃
//     /// 現在はサンプルのためdamageメソッドを呼び出すのみだが、フルーツごとの攻撃方法をここに実装する
//     /// </summary>
//     /// <param name="hp">敵機のHP</param>
//     /// <returns>攻撃後の敵機のHP</returns>
//     public override int Attack(int hp)
//     {
//         return Damage(hp);
//     }
// }
