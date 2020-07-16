var pesquisaTUSSViewModel = function () {
  var self = this;

  $('#row-select tbody').on('click', 'tr', function () {
    $(this).toggleClass('selected');
  });

  // Delete rows start

  var drow = $('#row-delete').DataTable();

  $('#row-delete tbody').on('click', 'tr', function () {
    if ($(this).hasClass('selected')) {
      $(this).removeClass('selected');
    } else {
      drow.$('tr.selected').removeClass('selected');
      $(this).addClass('selected');
    }
  });

  $('#row-delete-btn').on('click', function () {
    drow.row('.selected').remove().draw(!1);
  });

  // Delete rows end

  //Upload Start
  $('#btnUpload').on('click', function () {
    var fileExtension = ['xls', 'xlsx'];
    var filename = $('#fUpload').val();
    if (filename.length === 0) {
      alert("Please select a file.");
      return false;
    }
    else {
      var extension = filename.replace(/^.*\./, '');
      if ($.inArray(extension, fileExtension) === -1) {
        alert("Please select only excel files.");
        return false;
      }
    }
    var fdata = new FormData();
    var fileUpload = $("#fUpload").get(0);
    var files = fileUpload.files;
    fdata.append(files[0].name, files[0]);
    $.ajax({
      type: "POST",
      url: "/Index/ImportExcel", //?handler=Import
      beforeSend: function (xhr) {
        xhr.setRequestHeader("XSRF-TOKEN",
          $('input:hidden[name="__RequestVerificationToken"]').val());
      },
      data: fdata,
      contentType: false,
      processData: false,
      success: function (response) {
        if (response.length === 0)
          alert('Some error occured while uploading');
        else {
          $('#dvData').html(response);
        }
      },
      error: function (e) {
        $('#dvData').html(e.responseText);
      }
    });
  })
  //Upload Finish
}

function IniciaJS() {
  var vm = new (pesquisaTUSSViewModel);
  ko.applyBindings(vm);
}