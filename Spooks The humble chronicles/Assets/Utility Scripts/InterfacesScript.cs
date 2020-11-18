public interface ITakeDamage
{
    void TakeSwordDamage(float damage);
}

public interface IToggleShield
{
    void ToggleShieldCollider(bool toggle);
}
public interface IToggleSword
{
    void ToogleSwordCollider(bool switchOn);
}
public interface ITakeEnemyDamage
{
    void TakeEnemyDamage(float damage);
}