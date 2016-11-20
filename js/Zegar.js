var Zegar = {    

    init: function () {
        //utworzenie i zastartowanie zegara
        Zegar.makeZegar();
        setInterval(Zegar.makeZegar, 1000);
    },

    makeZegar: function(){
        var data = new Date()
        var godz = data.getHours();
        var min = data.getMinutes();
        var sek = data.getSeconds();
        
        if(min < 10){
            min = "0" + min
        }
        if(sek < 10){
            sek = "0" + sek
        }
        document.getElementById("zegar").innerHTML = godz + " : " + min + " : " + sek;
   }

}
