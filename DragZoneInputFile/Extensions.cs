using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DragZoneInputFile
{
    internal static class Extensions
    {
        internal static async ValueTask FocusDrag(this IJSObjectReference module,ElementReference elementReference, bool active = true)  
        {
            await module.InvokeVoidAsync("focusDrag", elementReference, active);
        }
    }
}
