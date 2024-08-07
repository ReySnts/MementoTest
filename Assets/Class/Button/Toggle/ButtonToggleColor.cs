using UnityEngine;
using UnityEngine.UI;

public sealed class ButtonToggleColor : AbstractButtonToggle
{
    [SerializeField] private Color clickedNormalColor;

    [SerializeField] private Color clickedHighlightedColor;

    [SerializeField] private Color clickedSelectedColor;

    private Color unclickedNormalColor;

    private Color unclickedHighlightedColor;

    private Color unclickedSelectedColor;

    private ColorBlock buttonColorBlock;

    protected override void OnEnable()
    {
        base.OnEnable();
        GetFirstButtonColors();
    }

    private void GetFirstButtonColors()
    {
        buttonColorBlock = button.colors;
        unclickedNormalColor = buttonColorBlock.normalColor;
        unclickedHighlightedColor = buttonColorBlock.highlightedColor;
        unclickedSelectedColor = buttonColorBlock.selectedColor;
    }

    protected override void OnClick()
    {
        buttonColorBlock.normalColor = isActive ? unclickedNormalColor : clickedNormalColor;
        buttonColorBlock.highlightedColor = isActive ? unclickedHighlightedColor : clickedHighlightedColor;
        buttonColorBlock.selectedColor = isActive ? unclickedSelectedColor : clickedSelectedColor;
        button.colors = buttonColorBlock;
        base.OnClick();
    }
}