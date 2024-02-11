using Microsoft.AspNetCore.Components;

namespace KristofferStrube.Blazor.Confetti;

public class ConfettiOptions : EventArgs
{
    /// <summary>
    /// The number of pieces of confetti to generate. The default is <c>300</c>.
    /// </summary>
    public int Pieces { get; set; } = 300;

    /// <summary>
    /// The time that the average confetti piece will be animated for. The default is <c>1000</c> milliseconds.
    /// </summary>
    public int Milliseconds { get; set; } = 1000;

    /// <summary>
    /// How much the animation time of each confetti piece can vary.
    /// </summary>
    public int VariationInMilliseconds { get; set; } = 200;

    /// <summary>
    /// The color of the confetti pieces. The default colors are <c>"#F4F"</c>, <c>"#44F"</c>, <c>"#4F4"</c>, <c>"#F44"</c>, and <c>"#9F0"</c>.
    /// </summary>
    public string[] Colors { get; set; } = ["#F4F", "#44F", "#4F4", "#F44", "#9F0"];

    /// <summary>
    /// How the confetti should be rendered. The default is <see cref="ConfettiOriginMode.FromBottomCenter"/>
    /// </summary>
    public ConfettiOriginMode Mode { get; set; } = ConfettiOriginMode.FromBottomCenter;

    /// <summary>
    /// From where the animation should start if the <see cref="ConfettiOriginMode.FromElement"/> value is chosen for the <see cref="Mode"/>.
    /// </summary>
    public ElementReference? Origin { get; set; }
}
