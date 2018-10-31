let fs = require('fs');
function copyFile (target,source){
    fs.readFile(source,function(err,data){
        fs.writeFile(target,data,function(err,data){
            console.log('ok');
        });
    })
};
copyFile('b.md','a.md');
