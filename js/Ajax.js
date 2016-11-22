var Ajax = {
    send: function (obj, url, dataType) {
        return $.ajax({
            type: "POST",
            url: Settings.urls.databaseUrl,
            data: obj,
            dataType: "text",
        })
    }
}