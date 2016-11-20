var Database = {

    methods: {

        //utworzenie tabeli, przesyłam obiekt do wysłania Ajaxem

        createTables: function (obj) {
            return Ajax.send(obj, Settings.urls.databaseUrl)
        },

    }
}