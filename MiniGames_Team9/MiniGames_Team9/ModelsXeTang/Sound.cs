using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace MiniGames_Team9
{
    /// <summary>
    /// Quản lý tất cả âm thanh có trong trò chơi
    /// </summary>
    class Sound
    {
        //Properties
        private static SoundPlayer clipBurst = new SoundPlayer(Properties.Resources.burst2);
        private static SoundPlayer clipHurt = new SoundPlayer(Properties.Resources.hurtClip);
        private static SoundPlayer clipZombieshoot = new SoundPlayer(Properties.Resources.gun_laser_mav);
        private static SoundPlayer clipPlayershoot = new SoundPlayer(Properties.Resources.laserClip);
        private static SoundPlayer Clicked = new SoundPlayer(Properties.Resources.click_room);
        private static SoundPlayer Selected = new SoundPlayer(Properties.Resources.select_sound);
        private static SoundPlayer start = new SoundPlayer(Properties.Resources.start);
        private static SoundPlayer takeitem = new SoundPlayer(Properties.Resources.prop);
        private static SoundPlayer gameover = new SoundPlayer(Properties.Resources.Gameover);
        //Method
        //Âm thanh player bắn
        public static void PlayerShoot()
        {
            clipPlayershoot.Play();
        }
        //Âm thanh attacker bắn
        public static void AttackerShoot()
        {
            clipPlayershoot.Play();
        }
        //Âm thanh attacker nổ
        public static void AttackerBurst()
        {
            clipBurst.Play();
        }
        //Âm thành click button
        public static void ClickSound()
        {
            Clicked.Play();
        }
        //Âm thành select
        public static void SelectSound()
        {
            Selected.Play();
        }
        //Âm thanh Bắt đầu game
        public static void Start()
        {
            start.Play();
        }
        //Âm thanh player lấy được item
        public static void TakeItem()
        {
            takeitem.Play();
        }
        //Âm thanh khi game over
        public static void GameOver()
        {
            gameover.Play();
        }
    }
}