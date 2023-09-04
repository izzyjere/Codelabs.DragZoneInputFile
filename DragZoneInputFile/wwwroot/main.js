export function saveAs({ fileName, blob }) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = blob;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}