﻿public interface ITakeSwordDamage
{
    void TakeSwordDamage(float damage);
}

public interface IMagicDamage
{
    void TakeMagicDamage(float damage);
}
public interface IDealSwordDamage
{
    void ToogleSwordCollider(bool switchOn);
}
public interface ITakeEnemyDamage
{
    void TakeEnemyDamage(float damage);
}