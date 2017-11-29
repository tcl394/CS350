var mongoose = require('mongoose');
mongoose.Promise = global.Promise;

var post = mongoose.model('post',{
    creator_id: String,
    title: String,
    body: String,
    time_created: { type: Date, default: Date.now }
    });

post.create_post = function(creator_id, title, body){
    var new_post = new post({ creator_id: creator_id, title: title, body: body});

    new_post.save(function (err) {
      if (err) {
        console.log(err);
      } else {

        console.log('successfully created post with id: ' );

        var query = post.findOne({ creator_id: creator_id }); //define the mongoose query to search the collection

        query.exec(function (err, post) { // actually execute the query
            if (err) return handleError(err);
                console.log(post._id) // log the _id of the found object in the console in order to verify that something was actually found
            })
      }
    });
}

module.exports = post;
