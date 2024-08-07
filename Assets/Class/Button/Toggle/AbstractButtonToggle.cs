public abstract class AbstractButtonToggle : AbstractButton
{
    protected bool isActive;

    protected override void OnClick() => isActive = !isActive;
}