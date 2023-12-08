$(function () {

    $("#TransactionFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#TransactionCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#TransactionFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/TransactionFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('QuanLyChiTieuCaNhan');

    var service = quanLyChiTieuCaNhan.transactions.transaction;
    var createModal = new abp.ModalManager(abp.appPath + 'Transactions/Transaction/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Transactions/Transaction/EditModal');

    var dataTable = $('#TransactionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('QuanLyChiTieuCaNhan.Transaction.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('QuanLyChiTieuCaNhan.Transaction.Delete'),
                                confirmMessage: function (data) {
                                    return l('TransactionDeletionConfirmationMessage', data.record.id);
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
                title: l('TransactionTransactionType'),
                data: "transactionType"
            },
            {
                title: l('TransactionCategoryId'),
                data: "categoryId"
            },
            {
                title: l('TransactionMoney'),
                data: "money"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewTransactionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
