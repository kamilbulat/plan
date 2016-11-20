var Ajax = {
    send: function (obj, url, dataType) {
        return $.ajax({
            type: "POST",
            url: "http://localhost:52139/server/Database.aspx",
            data: obj,
            dataType: "text",
        })
    }
}