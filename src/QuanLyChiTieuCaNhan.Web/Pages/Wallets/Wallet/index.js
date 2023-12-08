$(function () {

    $("#WalletFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#WalletCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#WalletFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/WalletFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('QuanLyChiTieuCaNhan');

    var service = quanLyChiTieuCaNhan.wallets.wallet;
    var createModal = new abp.ModalManager(abp.appPath + 'Wallets/Wallet/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Wallets/Wallet/EditModal');

    var dataTable = $('#WalletTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('QuanLyChiTieuCaNhan.Wallet.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('QuanLyChiTieuCaNhan.Wallet.Delete'),
                                confirmMessage: function (data) {
                                    return l('WalletDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('WalletName'),
                data: "name"
            },
            {
                title: l('WalletDescription'),
                data: "description"
            },
            {
                title: l('WalletMyMoney'),
                data: "myMoney"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewWalletButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
