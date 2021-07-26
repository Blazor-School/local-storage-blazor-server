class BlazorUtil
{
    getAllStorage()
    {
        return Object.entries(localStorage);
    };
}

window.BlazorUtil = new BlazorUtil();