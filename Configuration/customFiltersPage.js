define(["loading"],
    function (loading) {

        //const pluginId = "8A1C97CB-AF56-47FE-AC00-188D3776F9E4";



        //
        // this code is here to demonstrate how JS in one plugin file can call methods in another file
        //

        return function (view) {

            //view.addEventListener('viewshow', async () => {

            //loading.show();

            //---------------------------------------------------
            console.log("======== Second Code Area ========");

            function test(i) {
                console.log("=== TEST === ",i);
            };

            return test;
            //---------------------------------------------------

            //loading.hide();
            //});
        };
    }
);