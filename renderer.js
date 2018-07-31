const path = require('path');
const baseNetAppPath = path.join(__dirname, '\\src\\QuickStart.Core\\bin\\Debug\\netcoreapp2.1\\');

process.env.EDGE_USE_CORECLR = 1;
process.env.EDGE_APP_ROOT = baseNetAppPath;

var edge = require('electron-edge-js');

var useComposedAssembly = edge.func({
    assemblyFile: path.join(baseNetAppPath, 'QuickStart.Core.dll'),
    typeName: 'QuickStart.Core.LocalMethods',
    methodName: 'UseComposedAssembly'
});


window.onload = function () {
    document.getElementById("useComposedAssemblyButton").onclick = onUseComposedAssemblyClicked;
};

function onUseComposedAssemblyClicked() {
    const messageFromComposedAssembly = document.getElementById("messageFromComposedAssembly");
    new Promise((resolve, reject) => {
            useComposedAssembly('', function (error, result) {
                if (error) reject(error);
                else resolve(result);
            });
        })
        .then(result => {
            messageFromComposedAssembly.innerHTML = result;
        })
        .catch(error => {
            messageFromComposedAssembly.innerHTML = error['Message'];
            console.log(error);
        });
}