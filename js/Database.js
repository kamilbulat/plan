var Database = {

    methods: {

        //utworzenie tabeli, przesyłam obiekt do wysłania Ajaxem

        createTables: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        },

        dropTables: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        },

        insertData: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        },
        deleteData: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        },
        downloadData: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        }
    }
}