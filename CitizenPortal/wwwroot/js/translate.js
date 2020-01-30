function Translate() {
    //initialization
    this.init = function (attribute, lng) {
        this.attribute = attribute;
        this.lng = lng;
    }
    //translate 
    this.process = function () {

        var attributeName = 'data-tag';

        $().ready(function () {
            _self = this;
            $.ajax({
                url: "/Res/en.json",
                type: 'GET',
                success: function (result) {
                   // $("#page").html(result);
                  //  var LngObject = JSON.parse(result.responseText);
                    var LngObject = result;//JSON.parse(result);
                    var allDom = document.getElementsByTagName("*");
                    for (var i = 0; i < allDom.length; i++) {
                        var elem = allDom[i];
                        var key = elem.getAttribute(attributeName);
                        if (key != null) {
                            console.log(key);
                            elem.innerHTML = LngObject[key];
                        }
                    }





                }
            });
        });



      //  _self = this;
      //  var xrhFile = new XMLHttpRequest();
        //load content data 
       // xrhFile.open("GET", "/Res/" + this.lng + ".json", false);
      //  xrhFile.onreadystatechange = function () {
          //  if (xrhFile.readyState === 4) {
              //  if (xrhFile.status === 200 || xrhFile.status === 0) {
                  //  var LngObject = JSON.parse(xrhFile.responseText);
                   // console.log(LngObject["name1"]);
                   // var allDom = document.getElementsByTagName("*");
                   // for (var i = 0; i < allDom.length; i++) {
                        //var elem = allDom[i];
                       // var key = elem.getAttribute(_self.attribute);

                        //if (key != null) {
                          //  console.log(key);
                          //  elem.innerHTML = LngObject[key];
                        //}
                    //}

               // }
          //  }
      //  }
       // xrhFile.send();
    }
}