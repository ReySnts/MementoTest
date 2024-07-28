using UnityEngine;
using UnityEngine.UI;

public sealed class ButtonColorOnClick : AbstractButton
{
    [SerializeField] private Color clickedNormalColor;

    [SerializeField] private Color clickedHighlightedColor;

    [SerializeField] private Color clickedSelectedColor;

    private Color unclickedNormalColor;

    private Color unclickedHighlightedColor;

    private Color unclickedSelectedColor;

    private ColorBlock buttonColorBlock;

    private bool buttonIsClicked = false;

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
        buttonColorBlock.normalColor = buttonIsClicked ? unclickedNormalColor : clickedNormalColor;
        buttonColorBlock.highlightedColor = buttonIsClicked ? unclickedHighlightedColor : clickedHighlightedColor;
        buttonColorBlock.selectedColor = buttonIsClicked ? unclickedSelectedColor : clickedSelectedColor;
        buttonIsClicked = !buttonIsClicked;
        button.colors = buttonColorBlock;
    }
}