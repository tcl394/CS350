
/**
This file contains the information necessary to create the connection to the mongodb server that is hosted by a third-party cloud vendor
 **/

var password = "Eye45678";


var connection_string_1 = 'mongodb://nick-alm:';
var connection_string_2 = '@ds137090.mlab.com:37090/mytest';
var connection_string = connection_string_1.concat(password);
connection_string = connection_string.concat(connection_string_2);

var mongoose = require('mongoose');
mongoose.connect(connection_string, { useMongoClient: true });
mongoose.Promise = global.Promise;

var user = require('./user_model.js');
