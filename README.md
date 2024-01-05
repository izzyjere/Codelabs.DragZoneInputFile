# Codelabs.DragZoneInputFile
Drag Zone File Input Component
# How to use
Install the nuget package 
```shell
NuGet\Install-Package DragZoneInputFile -Version 8.0.0
```
# In your razor component
```razor

@page "/"
@using DragZoneInputFile
<div class="row">
    <DragZoneInputFile Height="500" Class="col-6" Multiple OnUpload="OnFileUploadComplete" FileFormats=".pdf,.docx"></DragZoneInputFile>
</div>

File Name: @_fileNames
@code{
    string _fileNames = string.Empty;
    private void OnFileUploadComplete(IEnumerable<IBrowserFile> files)
    {
        // Do something with the files
        foreach (var file in files)
        {
            _fileNames += $"{file.Name}, ";
            //upload to server
        }
    }
}
```
