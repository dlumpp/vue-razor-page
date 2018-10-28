﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var app = new Vue({
    el: '#app',
    data: {
        invoices: invoiceData
    },
    methods: {
        removeItem: function (invoice, itemIndex) {
            invoice.items.splice(itemIndex, 1);
        }
    }
})