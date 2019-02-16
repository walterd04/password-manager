export const mutations = {

    SHOW_MODAL: (state) => {
        state.showModal = true;
    },

    HIDE_MODAL: (state) => {
        state.showModal = false;
    },

    SET_USER: (state, payload) => {
        if (payload.body && payload.body.length > 0) {
            state.user.isLoggedIn = true;
            state.user.details = {
                userId: payload.body.userId,
                username: payload.body.username, 
                firstName: payload.body.fistName, 
                lastName: payload.body.lastName
            }
        } else {
            return;
        }
    }

}