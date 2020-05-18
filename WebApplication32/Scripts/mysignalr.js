$.connection.hub.start().done(function () {
    console.log('hello');
    $.connection.myHub.server.anounce('hi gani');
}).fail(function () { console.log('con failed'); });

$.connection.myHub.client.anounce = function (msg) { alert(msg); };

(function () { alert('hi');})();