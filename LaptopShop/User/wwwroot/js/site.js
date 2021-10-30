// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var sitePlusMinus = function () {
	$('.js-btn-minus').on('click', function (e) {
		e.preventDefault();
		if ($(this).closest('.input-group').find('.form-control').val() != 0) {
			$(this).closest('.input-group').find('.form-control').val(parseInt($(this).closest('.input-group').find('.form-control').val()) - 1);
		} else {
			$(this).closest('.input-group').find('.form-control').val(parseInt(0));
		}
	});
	$('.js-btn-plus').on('click', function (e) {
		e.preventDefault();
		$(this).closest('.input-group').find('.form-control').val(parseInt($(this).closest('.input-group').find('.form-control').val()) + 1);
	});
};
sitePlusMinus();
// Write your JavaScript code.
