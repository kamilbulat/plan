var UI = {
    init: function (){
        var actual;
        //kliki w poszczegolne elemmenty interfejsu
       
        $("#bt1").on("click", function () {
            $(actual).animate({left: "-30vw"}, 500)
            $("#ustawienia").animate({ left: "0vw" }, 500)
            actual = "#ustawienia"
        })

        $("#bt2").on("click", function () {
            $(actual).animate({ left: "-30vw" }, 500)
            $("#dzis").animate({ left: "0vw" }, 500)
            actual = "#dzis"
        })

        $("#bt3").on("click", function () {
            $(actual).animate({ left: "-30vw" }, 500)
            $("#tydzien").animate({ left: "0vw" }, 500)
            actual = "#tydzien"
        })

        $(".x").on("click", function () {
            $(actual).animate({ left: "-30vw" }, 500)
        })
        
        var stan = false;
        $("#menu").on("click", function () {
            if(stan == false){
                $("#bt1").animate({ bottom: "0vh" }, 500)
                $("#bt2").animate({ bottom: "16vh" }, 500)
                $("#bt3").animate({ bottom: "8vh" }, 500)
                stan = !stan
            }else{
                $("#bt1").animate({ bottom: "-8vh" }, 500)
                $("#bt2").animate({ bottom: "-8vh" }, 500)
                $("#bt3").animate({ bottom: "-8vh" }, 500)
                stan = !stan
            }
            
        })

        $("#baza").on("click",function(){
            $(actual).animate({ left: "-30vw" }, 500)
            $("#bazapanel").animate({ left: "0vw" }, 500)
            actual = "#bazapanel"
        })

            $(".option").click(function () {
                switch ($(this).index()) {
                    case 0:                   
                        var obj = {
                            action: "create"
                        }
                        Database.methods.createTables(obj)
                         .done(function (response) {
                             basealert(response)
                         })
                         .fail(function (response) {
                             basealert(response.responseText)
                         })

                        break;

                    case 1:
                        var obj = {
                            action: "drop"
                        }
                        Database.methods.dropTables(obj)
                         .done(function (response) {
                             basealert(response)
                         })
                         .fail(function (response) {
                             basealert(response.responseText)
                         })
                        break;

                    case 2:
                        var obj = {
                            action: "insert"
                        }
                Database.methods.insertData(obj)
                         .done(function (response) {
                             basealert(response)
                         })
                         .fail(function (response) {
                             basealert(response.responseText)
                         })
                break;
                    case 3:
                        var obj = {
                            action: "delete"
                        }
                        Database.methods.deleteData(obj)
                                 .done(function (response) {
                                     basealert(response)
                                 })
                                 .fail(function (response) {
                                     basealert(response.responseText)
                                 })
                        break;

                }
            })

            function basealert(alert) {
                $("#basealert").text(alert)
                $("#basealert").fadeIn(500, function () {
                    $("#basealert").css("display","block")
                    $("#basealert").on("click", function () {
                        $("#basealert").fadeOut(500);
                    })
                })
                
                
            }

        //koniec kodu
    }
}