function replaceAll(str, identifier, value)
{
    while (str.indexOf(identifier) != -1) 
    {
        str = str.replace(identifier, value);
    }

    return str;
}
function renderTemplate(template, data)
{
    Object.keys(data).forEach(function (k) {
        var identifier = '{{' + k + '}}';
        template = replaceAll(template, identifier, data[k]);
    });
    return template;
}