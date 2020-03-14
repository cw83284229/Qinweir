//$(function () {
//    var dataTable = $('#BooksTable').DataTable(abp.libs.datatables.normalizeConfiguration({
//        ajax: abp.libs.datatables.createAjax(qinweir.orderMaterial.materialName.getList),
//        columnDefs: [
//            { data: "materialsType" },
//            { data: "materialsName" },
//            { data: "units" },
//            { data: "unitPrice" },
           
//        ]
//    }));
//});
//var createModal = new abp.ModalManager(abp.appPath + 'MaterialName/Create');

//createModal.onResult(function () {
//    dataTable.ajax.reload();
//});

//$('#NewBookButton').click(function (e) {
//    e.preventDefault();
//    createModal.open();
//});



$(function () {

    var l = abp.localization.getResource('Qinwer');

    var createModal = new abp.ModalManager(abp.appPath + 'MaterialName/Create');
    var editModal = new abp.ModalManager(abp.appPath + 'MaterialName/Edit');

    var dataTable = $('#BooksTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: true,
        autoWidth: true,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(qinweir.orderMaterial.materialName.getList),
        columnDefs: [


            { data: "materialsType" },
            { data: "materialsName" },
            { data: "units" },
            { data: "unitPrice" },
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {  text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('BookDeletionConfirmationMessage', data.record.name);
                                },
                                action: function (data) {
                                    qinweir.orderMaterial.materialName
                                        .delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
           
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});