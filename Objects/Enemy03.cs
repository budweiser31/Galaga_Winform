﻿using Engine;
using Galaga.Properties;
using Galaga.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaga
{
    /// <summary>
    /// 보스 프리팹
    /// </summary>
    class Enemy03 : GameObject
    {
        public Enemy03()
        {
            Vec2D point = new Vec2D(-50, -50);
            transform.position = point;

            Tag = "Enemy";

            SpriteComponent spriteComponent = new SpriteComponent(this);
            spriteComponent.Image = Resources.Enemy_03_01;
            AddComponent(spriteComponent);

            AnimationSprite animationSprite = new AnimationSprite(this);
            animationSprite.ImageList.Add(Resources.Enemy_03_01);
            animationSprite.ImageList.Add(Resources.Enemy_03_02);
            AddComponent(animationSprite);

            BoxCollider boxCollider = new BoxCollider(this);
            Size boxSize = spriteComponent.Image.Size;
            boxSize.Width -= 5;
            boxSize.Height -= 5;
            boxCollider.Size = boxSize;
            AddComponent(boxCollider);

            HealthSystem healthSystem = new HealthSystem(this);
            healthSystem.Health = 3;
            AddComponent(healthSystem);

            DamageSystem damageSystem = new DamageSystem(this);
            damageSystem.HitAbleTag = "Player";
            AddComponent(damageSystem);

            BezierCurveMove bezierCurveMove = new BezierCurveMove(this);
            AddComponent(bezierCurveMove);

            EnemyBulletShooter enemyBulletShooter = new EnemyBulletShooter(this);
            enemyBulletShooter.ShootMinRotation = 177;
            enemyBulletShooter.ShootMaxRotation = 183;
            enemyBulletShooter.FireRate = 2f;
            enemyBulletShooter.FireProbability = 50;
            AddComponent(enemyBulletShooter);
        }
    }
}